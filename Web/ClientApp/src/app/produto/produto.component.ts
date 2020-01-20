import { Component } from "@angular/core"

@Component({
    selector: "produto",
    template: "<h1>teste</h1>"
})

export class ProdutoComponent {
    
    public nome: string;
    public liberadoParaVenda: boolean;

    public obterNome(): string {
        return "hahahaha";
    }
}
