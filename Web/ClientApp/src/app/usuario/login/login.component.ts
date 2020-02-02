import { Component, OnInit } from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { Router, RouterLinkActive, ActivatedRoute } from "@angular/router";
import { UsuarioServico } from "../../servicos/usuario/usuario.servico";

@Component({
    selector: "app-login",
    templateUrl: "./login.component.html",
    styleUrls: ["./login.component.css"]
})
export class LoginComponent implements OnInit {
    public usuario;
    public returnUrl: string;
    public mensagem: string;
    private ativar_spinner: boolean;

    constructor(private router: Router,
        private activatedRouter: ActivatedRoute,
        private usuarioServico: UsuarioServico) {
        this.usuario = new Usuario();
    }

    ngOnInit(): void {
        this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    }

    entrar() {
        this.ativar_spinner = true;
        this.usuarioServico.verificarUsuario(this.usuario)
            .subscribe(
                usuario_json => {
                    //sessionStorage.setItem("usuario-autenticado", "1");
                    this.usuarioServico.usuario = usuario_json;
                    if (this.returnUrl == null) {
                        this.router.navigate(['/']);
                    } else {
                        this.router.navigate([this.returnUrl]);
                    }
                },
                err => {
                    this.mensagem = err.error;
                    console.log(err.error);
                    this.ativar_spinner = false;
                }
        );
    }
}
