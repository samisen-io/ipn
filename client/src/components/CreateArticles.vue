<template>
  <div>
    <div class="signOut">
      <router-link to="/">Logout</router-link>
    </div>
    <viewprofile />
    <articles-list />
  </div>
</template>

<script>
import ArticlesList from "./ArticlesList.vue";
import Viewprofile from "./Viewprofile.vue";
export default {
  components: { Viewprofile, ArticlesList },
};
</script>

<style>
.signOut {
  text-align: right;
}
</style>