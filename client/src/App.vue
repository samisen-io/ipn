<template>
<div>
  <sign-in />
  <br />
  <sign-up />
 <create-articles />
 <br />
 <edit-article />
 <br />
 <spinner />
</div>
</template>

<script>
import SignUp from './assets/SignUp.vue'
import CreateArticles from './components/CreateArticles.vue'
import EditArticle from './components/EditArticle.vue'
import SignIn from './components/SignIn.vue'
import Spinner from './components/Spinner.vue'
export default {
  components: { CreateArticles, EditArticle, SignIn, SignUp, Spinner },
  

}
</script>

<style>

</style>