cmake_minimum_required(VERSION 3.15)
project(ChronosServer VERSION 1.0 LANGUAGES CXX)
set(CMAKE_CXX_STANDARD 20)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

include_directories(${CMAKE_SOURCE_DIR}/../External/asio/include)
include_directories(${CMAKE_SOURCE_DIR}/../Shared)

add_executable(ChronosServer main.cpp)

find_package(Threads REQUIRED)
target_link_libraries(ChronosServer PRIVATE Threads::Threads)

