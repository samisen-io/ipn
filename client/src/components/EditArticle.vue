<template>
  <div>
    <div class="signOut">
      <router-link to="/">Logout</router-link>
    </div>
    <div class="container">
      <div v-for="value in data" :key="value">
        <h1 class="mainHeading">Edit Article</h1>
            <div class="input-group">
              <span class="input-group-text">Title</span>
              <input
                type="text"
                aria-label="First name"
                class="form-control"
                v-model="value.title"
              />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <span class="input-group-text">Location</span>
              <input
                type="text"
                aria-label="Last name"
                class="form-control"
                v-model="value.Location"
              />
        </div>
        <div class="col d-flex justify-content-left">
          <div class="row">
            <h3 class="headingForAnArticle">Media</h3>
            <div class="col-6">
              <div>
                <input
                  class="input-group"
                  type="file"
                  ref="file"
                  multiple="multiple"
                />

                <div v-for="im in files" :key="im">
                  <div><b>{{ im.name }}</b></div>
                </div>
              </div>
            </div>
            <div class="col-6">
              <button @click="submitFiles()" class="btn btn-primary">
                Add
              </button>
            </div>
          </div>
        </div>

        <br />
        <h3 class="headingForAnArticle">Text</h3>
        <div class="editArticleTextCard">
          <textarea class="textarea" v-model="value.ArticleText">
          </textarea>
        </div>

        <div class="divforbuttons">
          <button type="button" class="btn btn-primary">Publish</button>&nbsp;
          <button
            type="button"
            class="btn btn-success"
            @click="goToCreateArticlePage()"
          >
            Save
          </button>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import router from "../router";
export default {
  readAsDataUrl(file) {
    let fr = new FileReader();
    if (fr.readAsDataURL) {
      fr.readAsDataURL(file);
    } else if (fr.readAsDataurl) {
      fr.readAsDataurl(file);
    }
    return fr.result;
  },
  created() {
    this.$getLocation({}).then((coordinates) => {
      this.coordinates = coordinates;
      console.log(coordinates);
    });
  },
  data() {
    return {
      formData: [],
      files: [],
      data: [
        {
          image: "",
          title: "Monkeys Attack",
          Location: "Telangana, India",
          ArticleText:
            "Many tourists visit the famous Badrachalam temple in Telangana duirng the festival season. However, the monkeys at the temple have become a constant nuisance to the tourists. One family who visited the temple in the recent days met with an angry monkey which did not let them pass as they were walking back to their guest room situated in the temple premises.",
        },
      ],
    };
  },
  methods: {
    goToCreateArticlePage() {
      router.push("CreateArticles");
    },
    submitFiles() {
      this.formData = new FormData();
      for (var i = 0; i < this.$refs.file.files.length; i++) {
        let file = this.$refs.file.files[i];
        this.formData.append("files[" + i + "]", file);
        this.files.push(file);
        console.log("Files");
      }
    },
    deleteColumn: function (index) {
      this.files.splice(index, 1);
    },
  },
};
</script>

<style>
.divforbuttons {
  margin-top: 30px;
  margin-bottom: 20px;
  text-align: right;
}
.headingForAnArticle {
  font-family: "Times New Roman", Times, serif;
  color: black;
  margin-top: 30px;
  margin-bottom: 20px;
  text-align: left;
}
.mainHeading {
  margin-top: 5px;
  margin-bottom: 20px;
  text-align: center;
}
.titleLabel {
  margin-bottom: 30px;

  float: left;
}

.thumbnail {
  content: "";
  clear: both;
  display: table;
  padding: 10px;
  max-width: 55%;
  max-height: 50%;
}
.inline {
  margin-top: 15px;
  margin-bottom: 20px;
  display: inline-block;
}
.EditArticleDetailsCard {
  align-items: center;
  text-align: center;
  border: 3px solid #0091d5;
  border-radius: 15px;
  height: 70px;
  width: 80%;
  margin-top: auto;
  margin-bottom: 30px;
  position: relative;
  display: flex;
  justify-content: center;
  flex-direction: column;
  padding: 10px;
  box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);
  -webkit-box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2),
    0 6px 20px 0 rgba(0, 0, 0, 0.19);
  -moz-box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2),
    0 6px 20px 0 rgba(0, 0, 0, 0.19);
}

.textarea {
  height: 200px;
  width: 100%;
}
.card-body {
  border: 3px solid red;
  border-radius: 15px;
  display: inline-block;
  margin-bottom: 30px;
  margin-top: 30px;
  height: 300px;
  width: 50%;
  box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);
  -webkit-box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2),
    0 6px 20px 0 rgba(0, 0, 0, 0.19);
  -moz-box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2),
    0 6px 20px 0 rgba(0, 0, 0, 0.19);
}
</style>