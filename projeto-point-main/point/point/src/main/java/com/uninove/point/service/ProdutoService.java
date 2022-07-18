package com.uninove.point.service;

import com.uninove.point.model.entity.Produto;
import com.uninove.point.model.entity.Usuario;
import com.uninove.point.model.repository.ProdutoRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class ProdutoService {

    @Autowired
    private ProdutoRepository produtoRepository;

    /*CREATE / SALVAR*/
    public Produto salvar(Produto produto){
        return produtoRepository.save(produto);
    }

    /*READ / VISUALIZAR*/
    public List<Produto> listar(Usuario usuario){
        return produtoRepository.produtoList(usuario.getId());
    }

    /*UPDATE / ALTERAR*/
    public void alterar(Produto produto){
        produtoRepository.save(produto);
    }

    /*DELETE / DELETAR*/
    public void deletar(Long id){
        produtoRepository.deleteById(id);
    }

    /*METHODS*/
    public Produto findById(Long id){
        return produtoRepository.getById(id);
    }
}
