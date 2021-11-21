<template>
  <div>
    <div class="signOut">
      <router-link to="/">Logout</router-link>
    </div>
    <articles-list />
  </div>
</template>

<script>
import ArticlesList from "./ArticlesList.vue";
export default {
  components: { ArticlesList },
};
</script>

<style>
.signOut {
  text-align: right;
}
</style>