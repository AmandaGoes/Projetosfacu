package com.uninove.point.controller;

import com.uninove.point.model.entity.Produto;
import com.uninove.point.model.entity.Usuario;
import com.uninove.point.service.ProdutoService;
import com.uninove.point.controller.request.MessageRequest;
import com.uninove.point.service.UsuarioService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController("/produto")
@CrossOrigin(origins = "*")
public class ProdutoController {

    private final ProdutoService produtoService;
    private final UsuarioService usuarioService;

    public ProdutoController(ProdutoService produtoService, UsuarioService usuarioService) {
        this.produtoService = produtoService;
        this.usuarioService = usuarioService;
    }

    /*CREATE / SALVAR*/
    @PostMapping("/salvar-produto")
    public ResponseEntity<Produto> salvarProduto(@RequestBody Produto produto, @CookieValue("token") String token){

        Usuario usuario = usuarioService.validationTokenUser(token);

        produto.setUsuario(usuario);

        return new ResponseEntity(produtoService.salvar(produto), HttpStatus.CREATED);
    }

    /*READ / VISUALIZAR*/
    @GetMapping("/listar-produto")
    public ResponseEntity<List<Produto>> listarProduto(@CookieValue("token") String token){

        Usuario usuario = usuarioService.validationTokenUser(token);

        return new ResponseEntity(produtoService.listar(usuario), HttpStatus.OK);
    }

    /*UPDATE - ALTERAR*/
    @PutMapping("/alterar-produto")
    public ResponseEntity<MessageRequest> alterarProduto(@RequestBody Produto produto, @CookieValue("token") String token){

        Usuario usuario = usuarioService.validationTokenUser(token);

        if(usuario.getId() == produto.getUsuario().getId()){
            produtoService.alterar(produto);
            return new ResponseEntity(new MessageRequest("Produto alterado com sucesso!"), HttpStatus.ACCEPTED);

        } else {
            throw new IllegalStateException("Esse registro não pertence ao usuário dessa sessão!");
        }
    }

    /*DELETE / DELETAR*/
    @DeleteMapping("/deletar-produto-{id}")
    public ResponseEntity<MessageRequest> deletarProduto(@PathVariable("id") Long id, @CookieValue("token") String token){

        Usuario usuario = usuarioService.validationTokenUser(token);
        Produto produto = produtoService.findById(id);

        if(usuario.getId() == produto.getUsuario().getId()){
            produtoService.deletar(produto.getId());
            return new ResponseEntity(new MessageRequest("Produto deletado com sucesso!"), HttpStatus.ACCEPTED);

        } else {
            throw new IllegalStateException("Esse registro não pertence ao usuário dessa sessão!");
        }
    }
}
