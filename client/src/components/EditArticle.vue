<template>
  <div>
    <div class="signOut">
      <router-link to="/">Logout</router-link>
    </div>
    <div class="container">
      <div v-for="value in data" :key="value">
        <h1 class="mainHeading">Edit Article</h1>
        <div class="col d-flex justify-content-center">
          <div class="EditArticleDetailsCard">
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
          </div>
        </div>
        <div class="col d-flex justify-content-center">
          <div class="row">
            <h1 class="mainHeading">Did U Like U to Add Photos ?</h1>
            <div class="col-6">
              <div>
                <input class="input-group" type="file" ref="file" multiple="multiple" />

                <div v-for="(im, index) in files" :key="im">
                  <div class="card-body">
                    <h4>FileName:-{{ im.name }}</h4>
                    <button
                      class="btn btn-outline-primary"
                      @click="deleteColumn(index)"
                    >
                      Delete Items
                    </button>
                  </div>
                </div>
              </div>
            </div>
            <div class="col-6">
              <button @click="submitFiles()" class="btn btn-primary">Add</button>
            </div>
          </div>
        </div>

        <br />
        <h1 class="headingForAnArticle">ArticleText</h1>
        <div class="editArticleTextCard">
          <textarea class="textarea" name="bio" v-model="value.ArticleText">
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
          title: "Samsung",
          Location: "Banglore",
          ArticleText:
            "At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.",
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
  text-align: center;
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
.editArticleTextCard {
  margin-top: 5px;
  height: 450px;
  width: 100%;
  box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);
  -webkit-box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2),
    0 6px 20px 0 rgba(0, 0, 0, 0.19);
  -moz-box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2),
    0 6px 20px 0 rgba(0, 0, 0, 0.19);
}
.textarea {
  height: 449px;
  width: 100%;
}

</style>