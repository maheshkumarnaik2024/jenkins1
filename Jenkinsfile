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
                sh 'dotnet build'
            }
        }

        stage('Publish') {
            steps {
                sh 'dotnet publish -c Release'
            }
        }

        stage('Check Version') {
            steps {
                sh 'dotnet --version'
            }
        }

    }

}
