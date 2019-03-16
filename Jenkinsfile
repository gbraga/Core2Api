pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                dotnet restore
                dotnet build
	    }
        }
        stage('Test') {
            steps {
                echo 'Testing..'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
            }
        }
    }
}
