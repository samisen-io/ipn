<template>
  <div class="container">
    <br />
    <br />
    <br />

    <h1 class="articleHeading">Articles</h1>

    <div class="modalforAddArticle">
      <button
        type="button"
        class="btn btn-primary"
        data-bs-toggle="modal"
        data-bs-target="#AddArticle"
      >
        Add Article
      </button>

      <div
        class="modal fade"
        id="AddArticle"
        tabindex="-1"
        aria-labelledby="AddArticleLabel"
        aria-hidden="true"
      >
        <div class="modal-dialog">
          <div class="modal-content">
            <div class="modal-header">
              <h5 class="modal-title" id="AddArticleLabel">Modal title</h5>
              <button
                type="button"
                class="btn-close"
                data-bs-dismiss="modal"
                aria-label="Close"
              ></button>
            </div>
            <div class="modal-body">
              <form v-on:submit.prevent autocomplete="off">
                <div class="container">
                  <div class="input-group mb-3">
                    <span class="input-group-text" style="width: 30%"
                      >Article Name</span
                    >
                    <input
                      type="text"
                      class="form-control"
                      aria-label="ArticleName"
                      placeholder="ArticleName"
                      aria-describedby="basic-addon1"
                      autocomplete="off"
                    />
                  </div>

                  <div class="input-group mb-3">
                    <span style="width: 30%" class="input-group-text"
                      >Date</span
                    >
                    <input
                      type="Date"
                      class="form-control"
                      aria-label="Date"
                      aria-describedby="basic-addon1"
                      autocomplete="off"
                    />
                  </div>

                  <div class="input-group mb-3">
                    <span style="width: 30%" class="input-group-text"
                      >Place</span
                    >
                    <input
                      type="text"
                      class="form-control"
                      aria-label="Place"
                      placeholder="Place"
                      aria-describedby="basic-addon1"
                      autocomplete="off"
                    />
                  </div>
                </div>
              </form>
            </div>
            <div class="modal-footer">
              <button
                type="button"
                class="btn btn-secondary"
                data-bs-dismiss="modal"
              >
                Close
              </button>
              <button type="button" class="btn btn-primary">
                Save changes
              </button>
            </div>
          </div>
        </div>
      </div>
    </div>
    <!-- end of modal -->
    <div class="forSearchBox">
      <input
        type="text"
        class="form-control"
        placeholder="Search Article By Name"
        aria-label="Search"
        aria-describedby="basic-addon1"
        v-model="search"
      />
    </div>
    <table class="table table-striped table-bordered">
      <thead>
        <tr>
          <th scope="col">ArticleName</th>
          <th scope="col">Date</th>
          <th scope="col">Place</th>
          <th scope="col">Status</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="value in filterDataResult" :key="value">
          <td scope="row">{{ value.ArticleName }}</td>
          <td>{{ value.Date }}</td>
          <td>{{ value.Place }}</td>
          <td>{{ value.Status }}</td>
          <td v-if="value.Status == 'Publish'">
            <button type="button" class="btn btn-success">View</button>
          </td>
          <td v-else>
            <button
              type="button"
              class="btn btn-info"
              @click="goToEditPage(value.ArticleName)"
            >
              Edit</button
            >&nbsp;
            <button
              type="button"
              class="btn btn-danger"
              @click="deleteAnRecordFromList()"
            >
              Delete
            </button>
          </td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script>
export default {
  computed: {
    filterDataResult() {
      return this.articleData.filter((x) => {
        return x.ArticleName.match(this.search);
      });
    },
  },
  methods: {
    goToEditPage(id) {
      this.$router.push({ name: "EditArticle", params: { ArticleName: id } });
    },
    deleteAnRecordFromList() {
      alert("Did u want to delete the record");
    },
  },
  data() {
    return {
      search: "",
      articleData: [
        {
          ArticleName: "IccWorldCupT21",
          Date: "10/11/2021",
          Place: "Dubai",
          Status: "Publish",
        },
        {
          ArticleName: "IccWorldCupT22",
          Date: "10/11/2021",
          Place: "Dubai",
          Status: "Draft",
        },
        {
          ArticleName: "IccWorldCupT23",
          Date: "10/11/2021",
          Place: "Dubai",
          Status: "Draft",
        },
        {
          ArticleName: "IccWorldCupT24",
          Date: "10/11/2021",
          Place: "Dubai",
          Status: "Draft",
        },
        {
          ArticleName: "IccWorldCupT25",
          Date: "10/11/2021",
          Place: "Dubai",
          Status: "Publish",
        },
        {
          ArticleName: "IccWorldCupT26",
          Date: "10/11/2021",
          Place: "Dubai",
          Status: "Publish",
        },
        {
          ArticleName: "IccWorldCupT27",
          Date: "10/11/2021",
          Place: "Dubai",
          Status: "Draft",
        },
        {
          ArticleName: "IccWorldCupT28",
          Date: "10/11/2021",
          Place: "Dubai",
          Status: "Draft",
        },
        {
          ArticleName: "IccWorldCupT29",
          Date: "10/11/2021",
          Place: "Dubai",
          Status: "Publish",
        },
        {
          ArticleName: "IccWorldCupT30",
          Date: "10/11/2021",
          Place: "Dubai",
          Status: "Draft",
        },
        {
          ArticleName: "IccWorldCupT31",
          Date: "10/11/2021",
          Place: "Dubai",
          Status: "Publish",
        },
        {
          ArticleName: "IccWorldCupT32",
          Date: "10/11/2021",
          Place: "Dubai",
          Status: "Publish",
        },
        {
          ArticleName: "IccWorldCupT33",
          Date: "10/11/2021",
          Place: "Dubai",
          Status: "Publish",
        },
        {
          ArticleName: "IccWorldCupT34",
          Date: "10/11/2021",
          Place: "Dubai",
          Status: "Publish",
        },
      ],
    };
  },
};
</script>
<style>
.modalforAddArticle {
  text-align: right;
}
.articleHeading {
  text-align: center;
}
.table {
  margin-top: 20px;
  text-align: center;
}
.forSearchBox {
  margin-bottom: 20px;
  width: 400px;
}
</style>