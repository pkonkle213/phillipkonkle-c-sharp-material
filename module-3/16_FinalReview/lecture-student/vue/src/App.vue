<!-- Main Application Template. 
     Note that you have classes from bootstrap available to you.
     See https://getbootstrap.com/docs/4.5/getting-started/introduction/ for reference on bootstrap -->
<template>
<div>
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
    <a class="navbar-brand" href="#">Mattisms</a>
    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarText" aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarText">
      <ul class="navbar-nav mr-auto">
        <li class="nav-item">
          <router-link class="nav-item" v-bind:to="{ name: 'home' }">
            <i class="fab fa-galactic-republic fa-lg"></i> <!-- This is a font awesome icon -->
            Home 
          </router-link>
        </li>
        <li class="nav-item">
      <router-link
        class="nav-item"
        v-bind:to="{ name: 'register' }"
        v-if="!$store.state.token">Register</router-link>
        </li>
        <li class="nav-item">
      <router-link
        class="nav-item"
        v-bind:to="{ name: 'login' }"
        v-if="!$store.state.token">
        Login
      </router-link>
        </li>
        <li class="nav-item">
      <router-link
        class="nav-item"
        v-bind:to="{ name: 'logout' }"
        v-if="$store.state.token">
        Logout
      </router-link>     
        </li>   
      </ul>
      <span class="navbar-text">
        Basically, it's Jevin's fault
      </span>
    </div>
  </nav>

  <div id="app" class="container"> <!-- If you start to get random styling you don't like, remove container from this div -->
    
    <router-view />
  </div>
  </div>
</template>

<script>
export default {
  
}
</script>

<!-- Application-Wide Styles go here. 
     Any valid CSS or SCSS is allowable here. See https://sass-lang.com/documentation/style-rules for info on SCSS -->
<style lang="scss">

@import './styles/colors.scss';

// Import the bootstrap styles. If you want to override Bootstrap colors, it needs to happen above this line
@import '../node_modules/bootstrap/scss/bootstrap';

// Your custom styles go below this point
nav a {
  color: white;
  text-decoration: none;
}

nav a:hover {
  color: $highlight;
}

nav li {
  margin-right: 1rem;
}

</style>