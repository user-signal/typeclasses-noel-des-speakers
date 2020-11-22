lazy val root = (project in file(".")).
  settings(
    inThisBuild(List(
      organization := "net.sigusr",
      scalaVersion := "2.13.3"
    )),
    name := "Type Classes"
  )

libraryDependencies += "org.scalatest" %% "scalatest" % "3.2.2" % Test
