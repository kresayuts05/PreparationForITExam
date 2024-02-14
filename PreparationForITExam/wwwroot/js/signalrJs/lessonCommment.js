class LessonComment {
    constructor(username, content, title, lessonId) {
        this.username = username;
        this.content = content;
        this.title = title;
        this.lessonId = lessonId;
    }
}

const username = username;
const contentInput = document.getElementById('messageContent');
const chat = document.getElementById('chat');
const title = document.getElementById('messageTitle');
const lessonId = document.getElementById('lessonId');
const messagesQueue = [];

clear