using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur37 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur37";
        public override double halfLife { get; } = 303.0d;
        public override double atomicWeight { get; } = 36.97113d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chlorine37() }, { 1.0d, new BetaParticle(-1, 2432560.0) }, { 0.001878d, new GammaParticle(638000.0, 0.00194) }, { 0.001878d, new GammaParticle(655000.0, 0.00189) }, { 0.00059157d, new GammaParticle(906310.0, 0.00137) }, { 0.0006573d, new GammaParticle(929920.0, 0.00133) }, { 0.000939d, new GammaParticle(1090280.0, 0.00114) }, { 0.00053523d, new GammaParticle(1169060.0, 0.00106) }, { 0.0016902d, new GammaParticle(1186250.0, 0.00105) }, { 0.0017841d, new GammaParticle(1374000.0, 0.0009) }, { 0.008451d, new GammaParticle(1900190.0, 0.00065) }, { 0.00034743d, new GammaParticle(3086200.0, 0.0004) }, { 0.9390000000000001d, new GammaParticle(3103370.0, 0.0004) }, { 0.0008451d, new GammaParticle(3627000.0, 0.00034) }, { 0.0007512d, new GammaParticle(3708000.0, 0.00033) }, { 0.00269493d, new GammaParticle(3741060.0, 0.00033) }, { 0.00030987d, new GammaParticle(4009640.0, 0.00031) }, { 0.000939d, new GammaParticle(4016040.0, 0.00031) }, { 0.000939d, new GammaParticle(4272340.0, 0.00029) }, { 3.756e-05d, new GammaParticle(4396070.0, 0.00028) } } },

        };
    }
}
    