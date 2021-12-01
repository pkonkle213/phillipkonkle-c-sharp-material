<template>
  <div id="app">
    <!-- Header at top (Branding) -->
    <header>
      Elevator Bugs
    </header>

    <!-- Sidebar (Navigation) -->
    <aside>
      <nav id="nav" class="mt-3">
        <ul>
          <li><router-link v-bind:to="{name:'Home'}">Home</router-link></li>
          <li><router-link v-bind:to="{name:'BugsList'}">Bugs</router-link></li>
          <li><router-link v-bind:to="{name:'About'}">About</router-link></li>
        </ul>
      </nav>
    </aside>

    <!-- Main Content (Active Page) -->
    <main>
      <router-view/>
    </main>
  </div>
</template>

<style lang="scss">

// SASS variables
$accentDark: #3D5A80;
$accentLight: #98C1D9;
$background: #E0FBFC;
$highlight: #EE6C4D;
$dark: #293241;
$light: white;

// Override bootstrap styles here. See https://getbootstrap.com/docs/4.0/getting-started/theming/#theme-colors for some pointers
$primary: $accentDark;
$danger: $highlight;
$warning: #ddbc2b;

// Import the bootstrap styles. If you want to override Bootstrap colors, it needs to happen above this line
@import '../node_modules/bootstrap/scss/bootstrap';

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
