<template>
  <div>
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-+0n0xVW2eSR5OomGNYDnhzAbDsOXxcvSN1TPprVMTNDbiYZCxYbOOl7+AMvyTG2x" crossorigin="anonymous">
  <div class="yuca container">
    <div class="form-floating mb-3">
  <input type="email" class="form-control" id="floatingInput" placeholder="name@example.com">
  <label for="floatingInput">Pokemon</label>
</div>
<button type="button" class="btn btn-dark">Buscar pokemon</button>

<table class="table table-success table-striped">
 <thead>
    <tr>
      <th>Nombre</th>
      <th>Habilidad</th>
      <th>Foto</th>
    </tr>
  </thead>
  <tbody>
    <tr v-for="poke in pokemon" :key="poke.id">
      <td>{{poke.name}}</td>
     <td>{{poke.Habilidad}}</td>
      <td>{{poke.url}}</td>
    </tr>
  </tbody>
</table>
<button type="button" class="btn btn-dark">Imprimir pokemon</button>

  </div>
  </div>
</template>

<script>
import axios from 'axios';
import Vue from 'vue';
import VueAxios from 'vue-axios';
Vue.use(VueAxios,axios)

export default {
  data(){
    return{
      pokemon: []
    }
  },
  name: 'Users',
  mounted(){
    Vue.axios.get('http://localhost:60618/Pokemon')
    .then((resp) =>{
      this.pokemon = resp.data.data;
      console.log(resp)
    })
  }, 
}

</script>




<style>
.yuca{
  padding: 20px;
  margin: auto;
  display: block;
  margin-top: 20rem;
}

</style>
