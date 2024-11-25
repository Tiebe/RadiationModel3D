using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium52 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium52";
        public override double halfLife { get; } = 0.11d;
        public override double atomicWeight { get; } = 51.9816d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Calcium52() }, { 1.0d, new BetaParticle(-1, 8563150.0) }, { 0.044000000000000004d, new GammaParticle(1427000.0, 0.00087) }, { 0.015d, new GammaParticle(1961000.0, 0.00063) }, { 0.252d, new GammaParticle(2563000.0, 0.00048) }, { 0.003d, new GammaParticle(3150000.0, 0.00039) }, { 0.004d, new GammaParticle(3388000.0, 0.00037) } } },
            { 0.74d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Calcium52() }, { 1.0d, new BetaParticle(-1, 8563150.0) }, { 0.044000000000000004d, new GammaParticle(1427000.0, 0.00087) }, { 0.015d, new GammaParticle(1961000.0, 0.00063) }, { 0.252d, new GammaParticle(2563000.0, 0.00048) }, { 0.003d, new GammaParticle(3150000.0, 0.00039) }, { 0.004d, new GammaParticle(3388000.0, 0.00037) } } },
            { 0.023d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Calcium50() }, { 1.0d, new BetaParticle(-1, 942718703.472) }, { 1.0d, new NeutronParticle() }, { 0.0055000000000000005d, new GammaParticle(1027000.0, 0.00121) } } },

        };
    }
}
    