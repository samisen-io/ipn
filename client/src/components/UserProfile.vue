<template>
  <div>
    <div class="signOut">
      <router-link to="/">Logout</router-link>
    </div>
    <div class="container">
      <div class="d-flex justify-content-center">
        <div class="alert alert-success" role="alert" id="delayedAlert">
          Welcome back !! {{ profile.firstName }}
        </div>
      </div>
      <div class="d-flex justify-content-center">
        <div class="viewProfilecard">
          <user-profile-pic-component />
          <div class="card-body">
            <h5 class="profileHeading">Profile Details</h5>
            <div class="EditForProfile">
              <button
                type="button"
                class="btn btn-info"
                data-bs-toggle="modal"
                data-bs-target="#Edit"
              >
                Edit Profile
              </button>
              <div
                class="modal fade"
                id="Edit"
                tabindex="-1"
                aria-labelledby="EditLabel"
                aria-hidden="true"
              >
                <div class="modal-dialog">
                  <div class="modal-content">
                    <div class="modal-header">
                      <h5 class="modal-title" id="EditLabel">
                        Change u r Details
                      </h5>
                      <button
                        type="button"
                        class="btn-close"
                        data-bs-dismiss="modal"
                        aria-label="Close"
                      ></button>
                    </div>
                    <div class="modal-body">
                      <div class="input-group mb-3">
                        <span
                          class="input-group-text"
                          id="inputGroup-sizing-default"
                          >FirstName</span
                        >
                        <input
                          type="text"
                          class="form-control"
                          aria-label="Sizing example input"
                          aria-describedby="inputGroup-sizing-default"
                          v-model="profile.firstName"
                        />
                      </div>
                      <div class="input-group mb-3">
                        <span
                          class="input-group-text"
                          id="inputGroup-sizing-default"
                          >MiddleName</span
                        >
                        <input
                          type="text"
                          class="form-control"
                          aria-label="Sizing example input"
                          aria-describedby="inputGroup-sizing-default"
                          v-model="profile.middleName"
                        />
                      </div>
                      <div class="input-group mb-3">
                        <span
                          class="input-group-text"
                          id="inputGroup-sizing-default"
                          >LastName</span
                        >
                        <input
                          type="text"
                          class="form-control"
                          aria-label="Sizing example input"
                          aria-describedby="inputGroup-sizing-default"
                          v-model="profile.lastName"
                        />
                      </div>
                      <div class="input-group mb-3">
                        <span
                          class="input-group-text"
                          id="inputGroup-sizing-default"
                          >Mobile</span
                        >
                        <input
                          type="text"
                          class="form-control"
                          aria-label="Sizing example input"
                          aria-describedby="inputGroup-sizing-default"
                          v-model="profile.mobile"
                        />
                      </div>
                      <div class="input-group mb-3">
                        <span
                          class="input-group-text"
                          id="inputGroup-sizing-default"
                          >Email</span
                        >
                        <input
                          type="text"
                          class="form-control"
                          aria-label="Sizing example input"
                          aria-describedby="inputGroup-sizing-default"
                          v-model="profile.email"
                        />
                      </div>
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

            <div class="input-group mb-3">
              <span class="input-group-text" id="inputGroup-sizing-default"
                >FirstName</span
              >
              <input
                type="text"
                disabled
                class="form-control"
                aria-label="Sizing example input"
                aria-describedby="inputGroup-sizing-default"
                v-model="profile.firstName"
              />
            </div>
            <div class="input-group mb-3">
              <span class="input-group-text" id="inputGroup-sizing-default"
                >MiddleName</span
              >
              <input
                type="text"
                disabled
                class="form-control"
                aria-label="Sizing example input"
                aria-describedby="inputGroup-sizing-default"
                v-model="profile.middleName"
              />
            </div>
            <div class="input-group mb-3">
              <span class="input-group-text" id="inputGroup-sizing-default"
                >LastName</span
              >
              <input
                type="text"
                class="form-control"
                disabled
                aria-label="Sizing example input"
                aria-describedby="inputGroup-sizing-default"
                v-model="profile.lastName"
              />
            </div>
            <div class="input-group mb-3">
              <span class="input-group-text" id="inputGroup-sizing-default"
                >Mobile</span
              >
              <input
                type="text"
                class="form-control"
                disabled
                aria-label="Sizing example input"
                aria-describedby="inputGroup-sizing-default"
                v-model="profile.mobile"
              />
            </div>
            <div class="input-group mb-3">
              <span class="input-group-text" id="inputGroup-sizing-default"
                >Email</span
              >
              <input
                type="text"
                disabled
                class="form-control"
                aria-label="Sizing example input"
                aria-describedby="inputGroup-sizing-default"
                v-model="profile.email"
              />
            </div>
            <div class="input-group mb-3">
              <span class="input-group-text" id="inputGroup-sizing-default"
                ><i class="fa fa-clock fa-2x" aria-hidden="true"></i
              ></span>
              <input
                type="text"
                disabled
                class="form-control"
                aria-label="Sizing example input"
                aria-describedby="inputGroup-sizing-default"
                v-model="profile.lastLogin"
              />
            </div>
          </div>
          <div class="LinkForGoToArticlesPage">
            <a href="/ArticlesList">Create An Article</a>
            <!-- <router-link to="ArticlesList">Create An Article</router-link> -->
          </div>
        </div>
      </div>
    
    </div>
  </div>
</template>

<script>
import axios from "axios";
import UserProfilePicComponent from "./UserProfilePicComponent.vue";

export default {
  components: { UserProfilePicComponent },
  data() {
    return {
      profile: {},
      id: "",
      showAlert: false,
    };
  },
  mounted() {
    this.id = this.$route.params.id;
    axios
      .get("http://ipn.azurewebsites.net/user/" + this.id)
      .then((response) => {
        this.profile = response.data;
        console.log(response);
        console.log(response.data.firstName);
      });
  },

};
</script>

<style>
.profileHeading {
  text-align: center;
}
.LinkForGoToArticlesPage {
  margin-top: 15px;
  text-align: center;
}
.EditForProfile {
  text-align: right;
  margin-bottom: 10px;
}
.card-img-top {
  height: 250px;
  width: 100%;
}
.alertStyle {
  width: 50%;
  text-align: center;
}
.viewProfilecard {
  width: 45%;
  border: 3px solid red;
  border-radius: 25px;
  margin-top: 30px;
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
</style>