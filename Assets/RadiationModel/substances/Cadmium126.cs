using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium126 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium126";
        public override double halfLife { get; } = 0.514d;
        public override double atomicWeight { get; } = 125.92243d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium126() }, { 1.0d, new BetaParticle(-1, 2776650.0) }, { 0.013919999999999998d, new GammaParticle(62930.0, 0.0197) }, { 0.01044d, new GammaParticle(102800.0, 0.01206) }, { 0.87d, new GammaParticle(260090.0, 0.00477) }, { 0.00522d, new GammaParticle(277400.0, 0.00447) }, { 0.00522d, new GammaParticle(325300.0, 0.00381) }, { 0.02001d, new GammaParticle(365820.0, 0.00339) }, { 0.72819d, new GammaParticle(428110.0, 0.0029) }, { 0.04176d, new GammaParticle(555400.0, 0.00223) }, { 0.00783d, new GammaParticle(585600.0, 0.00212) }, { 0.01044d, new GammaParticle(653080.0, 0.0019) }, { 0.05133d, new GammaParticle(688230.0, 0.0018) } } },

        };
    }
}
    