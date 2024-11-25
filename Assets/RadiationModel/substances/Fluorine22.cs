using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine22 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine22";
        public override double halfLife { get; } = 4.23d;
        public override double atomicWeight { get; } = 22.003d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neon22() }, { 1.0d, new BetaParticle(-1, 5408858.0) }, { 1.0d, new GammaParticle(1274537.0, 0.00097) }, { 0.0125d, new GammaParticle(1431100.0, 0.00087) }, { 0.0004d, new GammaParticle(1453100.0, 0.00085) }, { 0.087d, new GammaParticle(1900000.0, 0.00065) }, { 0.8190000000000001d, new GammaParticle(2082600.0, 0.0006) }, { 0.616d, new GammaParticle(2166100.0, 0.00057) }, { 0.051d, new GammaParticle(2283900.0, 0.00054) }, { 0.0002d, new GammaParticle(2552500.0, 0.00049) }, { 0.07d, new GammaParticle(2987700.0, 0.00041) }, { 0.0004d, new GammaParticle(3179400.0, 0.00039) }, { 0.012d, new GammaParticle(3983500.0, 0.00031) }, { 0.01d, new GammaParticle(4247900.0, 0.00029) }, { 0.113d, new GammaParticle(4366100.0, 0.00028) }, { 1.1999999999999999e-05d, new GammaParticle(4456000.0, 0.00028) }, { 0.003d, new GammaParticle(4634800.0, 0.00027) } } },
            { 0.11d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neon22() }, { 1.0d, new BetaParticle(-1, 5408858.0) }, { 1.0d, new GammaParticle(1274537.0, 0.00097) }, { 0.0125d, new GammaParticle(1431100.0, 0.00087) }, { 0.0004d, new GammaParticle(1453100.0, 0.00085) }, { 0.087d, new GammaParticle(1900000.0, 0.00065) }, { 0.8190000000000001d, new GammaParticle(2082600.0, 0.0006) }, { 0.616d, new GammaParticle(2166100.0, 0.00057) }, { 0.051d, new GammaParticle(2283900.0, 0.00054) }, { 0.0002d, new GammaParticle(2552500.0, 0.00049) }, { 0.07d, new GammaParticle(2987700.0, 0.00041) }, { 0.0004d, new GammaParticle(3179400.0, 0.00039) }, { 0.012d, new GammaParticle(3983500.0, 0.00031) }, { 0.01d, new GammaParticle(4247900.0, 0.00029) }, { 0.113d, new GammaParticle(4366100.0, 0.00028) }, { 1.1999999999999999e-05d, new GammaParticle(4456000.0, 0.00028) }, { 0.003d, new GammaParticle(4634800.0, 0.00027) } } },

        };
    }
}
    