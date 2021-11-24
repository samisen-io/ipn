<template>
  <h1>Hello</h1>
</template>

<script>
export default {
  data() {
    return {
      id: "",
    };
  },
  mounted() {
    this.id = this.$route.params.id;
    console.log(this.id);
  },
};
</script>

<style>
</style>