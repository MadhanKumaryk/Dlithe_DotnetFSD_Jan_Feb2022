const quizQuestions = [
    {
        question: "Choose the correct HTML element for the largest heading",
        option1: "<h1>",
        option2: "<head>",
        option3: "<heading>",
        option4: "<h6>",
        correct: "option4",
    },
    {
        question: "What is the correct HTML element for inserting a line break?",
        option1: "<break>",
        option2: "<br>",
        option3: "<lb>",
        option4: "<b>",
        correct: "option2",
    },
    {
        question: "What does CSS stand for?",
        option1: "Computer Style sheet",
        option2: "Cascading style sheet",
        option3: "Creative Style sheet",
        option4: "Colorful Style Sheet",
        correct: "option2",
    },
    {
        question: "Inside which HTML element do we put Javascript?",
        option1: "<scripting>",
        option2: "<script>",
        option3: "<js>",
        option4: "<javascript>",
        correct: "option2",
    },


];

const quiz = document.getElementById('quiz')

const answerEls = document.querySelectorAll('.answer')

const questionEl = document.getElementById('question')

const option1_text = document.getElementById('option1_text')

const option2_text = document.getElementById('option2_text')

const option3_text = document.getElementById('option3_text')

const option4_text = document.getElementById('option4_text')

const submitBtn = document.getElementById('submit')


//initialize array item index 0
let currentQuiz = 0

//inittially score is 0
let score = 0

loadQuiz()


//load quiz to html
function loadQuiz() {

    deselectAnswers()

    const currentQuizQuestions = quizQuestions[currentQuiz]

    questionEl.innerText = currentQuizQuestions.question
    option1_text.innerText = currentQuizQuestions.option1
    option2_text.innerText = currentQuizQuestions.option2
    option3_text.innerText = currentQuizQuestions.option3
    option4_text.innerText = currentQuizQuestions.option4
}

//deselect answers
function deselectAnswers() {
    answerEls.forEach(answerEl => answerEl.checked = false)
}

function getSelected() {
    let answer
    answerEls.forEach(answerEl => {
        if (answerEl.checked) {
            answer = answerEl.id
        }
    })
    return answer
}

//evaluate the answer
submitBtn.addEventListener('click', () => {
    const answer = getSelected()
    if (answer) {
        if (answer === quizQuestions[currentQuiz].correct) {
            score++
        }

        currentQuiz++

        if (currentQuiz < quizQuestions.length) {
            loadQuiz()
        }
        else {
            quiz.innerHTML = "You answered correctly " + score + ' quesions out of ' + quizQuestions.length + " quesions";
        }
    }
})