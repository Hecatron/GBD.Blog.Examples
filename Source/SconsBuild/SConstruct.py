#!python

# These import lines are not really needed, but it helps intellisense within VS when editing the script
import SCons.Script
from SCons.Environment import Environment

# For a more detailed / cross platform build script see
# https://bitbucket.org/scons/scons/wiki/AllInSConstruct

print "Building Hello1.c"
env = Environment()

# Add the Debug Flags if debug=1 is specified on the command line, this tends to be compiler specific
if ARGUMENTS.get('debug', 0):
    env.Append(CPPDEFINES = ['DEBUG', '_DEBUG'])
    env.Append(CCFLAGS='/MDd')
    env.Append(CCFLAGS=Split('/Zi /Fd${TARGET}.pdb'))
    env.Append(LINKFLAGS = ['/DEBUG'])
    variant = 'Debug'
else:
    env.Append(CPPDEFINES = ['NDEBUG'])
    variant = 'Release'

print "Building: " + variant

# Create a hello1.exe from the c file
t = env.Program(target='src/hello1', source=['src/hello1.c'])
Default(t)
