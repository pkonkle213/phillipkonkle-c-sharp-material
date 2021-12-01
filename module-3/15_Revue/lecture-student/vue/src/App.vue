<!-- Main Application Template. 
     Note that you have classes from bootstrap available to you.
     See https://getbootstrap.com/docs/4.5/getting-started/introduction/ for reference on bootstrap -->
<template>
  <div id="app">
    <!-- Header at top (Branding) -->
    <header>Elevator Bugs</header>

    <!-- Sidebar (Navigation) -->
    <aside>
      <nav id="nav" class="mt-3">
        <ul>
          <li>
            <router-link class="nav-item" v-bind:to="{ name: 'Home' }">
              <i class="fas fa-home"></i><!-- This is a font awesome icon -->
              Home
            </router-link>
          </li>
          <li>
            <router-link v-bind:to="{ name: 'BugsList' }">Bugs</router-link>
          </li>
          <li>
            <router-link v-bind:to="{ name: 'About' }">About</router-link>
          </li>
          <li v-if="!$store.state.token">
            <router-link v-bind:to="{ name: 'register' }">Register</router-link>
          </li>
          <li v-if="!$store.state.token">
            <router-link v-bind:to="{ name: 'login' }">Login</router-link>
          </li>
          <li v-if="$store.state.token">
            <router-link v-bind:to="{ name: 'logout' }">Logout</router-link>
          </li>
        </ul>
      </nav>
    </aside>

    <!-- Main Content (Active Page) -->
    <main>
      <router-view />
    </main>
  </div>
</template>

<script>
export default {};
</script>

<!-- Application-Wide Styles go here. 
     Any valid CSS or SCSS is allowable here. See https://sass-lang.com/documentation/style-rules for info on SCSS -->
<style lang="scss">
@import "./styles/colors.scss";

// Import the bootstrap styles. If you want to override Bootstrap colors, it needs to happen above this line
@import "../node_modules/bootstrap/scss/bootstrap";

// Custom selectors go here
html {
  background-color: $background;
  color: $dark;
  margin: 0;
  padding: 0;
}

body {
  margin: 0;
  padding: 0;
}

#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: $dark;
  background-color: $background;

  height: 100vh;
  width: 100vw;

  display: grid;
  grid-template-areas: "brand brand"
    "sidebar page";
  grid-template-columns: auto 1fr;
  grid-template-rows: auto 1fr;
}

#app > header {
  grid-area: brand;
  background-color: $accentDark;
  color: $light;
  font-size: 150%;
  padding: 0.5rem 1rem;
}

#app > aside {
  grid-area: sidebar;
  background-color: $dark;
  color: $light;
  min-width: 150px;
}

#app > main {
  grid-area: page;
  padding: 1rem 2rem;
}

#nav {
  padding-right: 2rem;
  a {
    text-align: left;
    font-weight: bold;
    color: $accentLight;

    &.router-link-exact-active {
      color: $highlight;
    }
  }

  li {
    text-align: left;
    list-style-type: none;
    margin-bottom: 0.5rem;
  }
}

#app a:hover {
  color: $light;
}

</style>