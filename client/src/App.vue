<template>
<div>
  <sign-in />
 <create-articles />
 <edit-article />
</div>
</template>

<script>
import CreateArticles from './components/CreateArticles.vue'
import EditArticle from './components/EditArticle.vue'
import SignIn from './components/SignIn.vue'



export default {
  components: { CreateArticles, EditArticle, SignIn },
  

}
</script>

<style>

</style>