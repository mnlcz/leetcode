import Problems.*

val problems = arrayOf<() -> Unit>(
    ::test1,
    ::test217,
    ::test242,
)

fun main() {
    problems.forEach { 
        it() 
        println()
    }
}
