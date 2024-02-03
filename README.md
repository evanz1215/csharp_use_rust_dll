# How to use the same lib you are exporting as a DLL from within Rust

**Note: if you don't want to export as a DLL and just want to use a library from the same crate as your binary, just remove everything below `edition = "2018"` and the `no_mangle` and `extern`s from the `lib.rs` example here.**

I couldn't find any good info on this for some reason, but here is what you need to do in order to accomplish this with minimal extra configuration.
The bin (`main.rs`) is also what will be compiled/run when you type `cargo run`, which means you don't lose the convenience of having a standalone bin project.

Use `cargo build --lib` to build the `.dll`/`.so` itself.

Directory tree:

```
│   Cargo.toml
│
└───src/
        lib.rs
        main.rs
```

SEO:  
- Use rust.rs and lib.rs in same project
- Use lib.rs as DLL
- Export normal rust lib as DLL
- Use exported rust-lang library from within rust-lang
- Use rust DLL without unsafe (note that the final executable won't actually use the library as a DLL, but I am trying to catch people who are searching for solutions to the same problem I was having)