pipeline {
    agent any

    stages {
	stage ('Checkout') {
	    checkout scm
	}
        stage('Build') {
            steps {
                bat 'nuget restore CoreApi.sln'
            }
	    steps {
                bat "\"${tool 'MSBuild'}\" CoreApi.sln /p:Configuration=Release /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"
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
