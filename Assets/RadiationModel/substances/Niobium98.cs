using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium98 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium98";
        public override double halfLife { get; } = 2.86d;
        public override double atomicWeight { get; } = 97.91033d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum98() }, { 1.0d, new BetaParticle(-1, 2295490.0) }, { 0.00312d, new GammaParticle(326700.0, 0.0038) }, { 0.0338d, new GammaParticle(645100.0, 0.00192) }, { 0.00169d, new GammaParticle(697400.0, 0.00178) }, { 0.13d, new GammaParticle(787400.0, 0.00157) }, { 0.0325d, new GammaParticle(971700.0, 0.00128) }, { 0.0611d, new GammaParticle(1024300.0, 0.00121) }, { 0.00884d, new GammaParticle(1250200.0, 0.00099) }, { 0.01664d, new GammaParticle(1419700.0, 0.00087) }, { 0.0338d, new GammaParticle(1432400.0, 0.00087) }, { 0.006500000000000001d, new GammaParticle(1758400.0, 0.00071) }, { 0.0032500000000000003d, new GammaParticle(1821000.0, 0.00068) }, { 0.008607812650482572d, new GammaParticle(2440.0, 0.50813) }, { 0.04834203240801117d, new GammaParticle(17374.0, 0.07136) }, { 0.09213270899182613d, new GammaParticle(17479.0, 0.07093) }, { 0.024175289117857615d, new GammaParticle(19681.0, 0.063) }, { 0.027898283642007686d, new GammaParticle(19794.0, 0.06264) }, { 0.0037229945241500726d, new GammaParticle(19963.0, 0.06211) } } },

        };
    }
}
    