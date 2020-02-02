import { Injectable, Inject } from "@angular/core"
import { HttpClient, HttpHeaders } from "@angular/common/http"
import { observable, Observable } from "rxjs";
import { Usuario } from "../../modelo/usuario";

@Injectable({
    providedIn: "root"
})
export class UsuarioServico {
    private baseURL: string;
    private _usuario: Usuario;

    get usuario(): Usuario {
        let usuario_json = sessionStorage.getItem("usuario-autenticado");
        this.usuario = JSON.parse(usuario_json);
        return this._usuario;
    }

    set usuario(usuario: Usuario) {
        sessionStorage.setItem("usuario-autenticado", JSON.stringify(usuario));
        this._usuario = usuario;
    }

    public usuario_autenticado(): boolean {
        return this._usuario != null && this._usuario.email != "" && this._usuario.senha != "";
    }

    public limpar_sessao() {
        sessionStorage.setItem("usuario-autenticado", "");
        this._usuario = null;
    }


    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.baseURL = baseUrl;
    }

    public verificarUsuario(_usuario: Usuario): Observable<Usuario> {
        const headers = new HttpHeaders().set('content-type', 'application/json');
        var body = {
            email: _usuario.email,
            senha:  _usuario.senha
        }

        return this.http.post<Usuario>(this.baseURL + "api/usuario/verificaUsuario", body, { headers });
    }

    public cadastrarUsuario(_usuario: Usuario): Observable<Usuario> {
        const headers = new HttpHeaders().set('content-type', 'application/json');
        var body = {
            email: _usuario.email,
            senha: _usuario.senha,
            nome: _usuario.nome,
            sobrenome: _usuario.sobrenome
        }

        return this.http.post<Usuario>(this.baseURL + "api/usuario", body, { headers });
    }
}
