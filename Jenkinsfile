node {
	stage 'Checkout'
		checkout scm

	stage 'Build'
		bat 'nuget restore CoreApi.sln'
		bat "\"${tool 'MSBuild'}\" CoreApi.sln /p:Configuration=Release /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"

	stage 'Archive'
		archive 'Core2Api/bin/Release/**'

}
