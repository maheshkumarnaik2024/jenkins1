pipeline {

    agent {
        docker {
            image 'mcr.microsoft.com/dotnet/sdk:8.0'
        }
    }

    stages {

        stage('Restore') {
            steps {
                sh 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                sh 'dotnet build --no-restore'
            }
        }

        stage('Test') {
            steps {
                sh 'dotnet test'
            }
        }

        stage('Publish') {
            steps {
                sh 'dotnet publish -c Release -o publish'
            }
        }

        stage('Archive') {
            steps {
                archiveArtifacts artifacts: 'publish/**'
            }
        }

    }
}