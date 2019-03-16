pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                echo 'dotnet restore CoreApi.sln'
                echo 'dotnet build'
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
