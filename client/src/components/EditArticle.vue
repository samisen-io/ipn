<template>
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
      <div class="thumbnail">
        <h3>Upload u r Images and videos</h3>
        <input id="files" type="file" multiple />
        <output id="result" />
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
</template>

<script>
import router from "../router";
window.onload = function () {
  if (window.File && window.FileList && window.FileReader) {
    var filesInput = document.getElementById("files");
    filesInput.addEventListener("change", function (event) {
      var files = event.target.files;
      var output = document.getElementById("result");
      for (var i = 0; i < files.length; i++) {
        var file = files[i];
        if (file.type.match("image")) {
          var picReader = new FileReader();
          picReader.addEventListener("load", function (event) {
            var picFile = event.target;
            var div = document.createElement("div");
            div.innerHTML =
              "<img  src='" +
              picFile.result +
              "'" +
              "title='" +
              picFile.name +
              "'/>";

            output.insertBefore(div, null);
          });

          picReader.readAsDataURL(file);
        } else if (file.type.match("video")) {
          let reader = new FileReader();
          reader.readAsArrayBuffer(file);
          reader.onload = function (e) {
            let buffer = e.target.result;
            let videoBlob = new Blob([new Uint8Array(buffer)], {
              type: "video/mp4",
            });
            let url = window.URL.createObjectURL(videoBlob);

            var div = document.createElement("div");
            div.innerHTML =
              "<video class='thumbnail' controls>'" +
              "<source src='" +
              url +
              "'" +
              " type='video/mp4'>'" +
              "</video>";
            output.insertBefore(div, null);
          };
          picReader.readAsDataURL(file);
        }
      }
    });
  } else {
    console.log("");
  }
};

export default {
  created() {
    this.$getLocation({}).then((coordinates) => {
      this.coordinates = coordinates;
      console.log(coordinates);
    });
  },
  data() {
    return {
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