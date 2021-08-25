package com.donizete.citiesapi;

import antlr.ASTNULLType;
import com.donizete.citiesapi.Country.Country;
import com.donizete.citiesapi.repository.CountryRepository;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RequestMapping("/Countries")
@RestController

public class CountyResource {

    private CountryRepository repository;

    @GetMapping
        public List<Country> countries(){
    return repository.findAll();
        }

    }
