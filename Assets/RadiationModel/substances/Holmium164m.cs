using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium164m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium164m";
        public override double halfLife { get; } = 2196.0d;
        public override double atomicWeight { get; } = 163.93039d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium164() }, { 0.114268d, new GammaParticle(37340.0, 0.0332) }, { 0.00021888999999999999d, new GammaParticle(45790.0, 0.02708) }, { 0.065296d, new GammaParticle(56640.0, 0.02189) }, { 0.0013727000000000001d, new GammaParticle(94000.0, 0.01319) }, { 0.45608454230950235d, new GammaParticle(7656.0, 0.16194) }, { 0.2105515317979925d, new GammaParticle(46700.0, 0.02655) }, { 0.37498046624753784d, new GammaParticle(47547.0, 0.02608) }, { 0.12114935864322997d, new GammaParticle(53982.0, 0.02297) }, { 0.15264819189046974d, new GammaParticle(54577.0, 0.02272) }, { 0.03149883324723979d, new GammaParticle(55293.0, 0.02242) } } },

        };
    }
}
    