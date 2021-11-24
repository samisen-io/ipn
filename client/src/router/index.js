import { createWebHistory, createRouter } from "vue-router";
import SignIn from "../components/SignIn.vue"
import SignUp from "../components/SignUp.vue"
import EditArticle from "../components/EditArticle.vue"
import NewsFeed from "../components/NewsFeed.vue"
import ArticlesList from "../components/ArticlesList.vue"
import UserProfile from "../components/UserProfile.vue"
import ForgotPassword from "../components/ForgotPassword.vue"
import ResetPassword from "../components/ResetPassword.vue"
import User from "../components/User.vue"
import SignInWithID from "../components/SignInWithID.vue"
const routes = [
    {
        path: "/",
        name: "SignIn",
        component: SignIn,

    },
    {
        path: "/SignInWithID/:id",
        name: "SignInWithID",
        component: SignInWithID,

    },
    {
        path: "/signup",
        name: "SignUp",
        component: SignUp,
    },
    {
        path: "/user",
        component: User
    },

    {
        path: "/ForgotPassword",
        component: ForgotPassword
    },
    {
        path: "/resetpassword",
        name: "ResetPassword",
        component: ResetPassword
    },
    {
        path: "/user/:id",
        name: "UserProfile",
        component: UserProfile
    },
    {
        path: "/articleslist",
        name: "ArticlesList",
        component: ArticlesList
    },
    {
        path: "/editarticle/:ArticleName",
        name: "EditArticle",
        component: EditArticle,
    },
    {
        path: "/newsfeed",
        name: "NewsFeed",
        component: NewsFeed
    }

];

const router = createRouter({
    history: createWebHistory(),
    routes,
});

export default router;