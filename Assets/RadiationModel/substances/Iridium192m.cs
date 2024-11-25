using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium192m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium192m";
        public override double halfLife { get; } = 87.0d;
        public override double atomicWeight { get; } = 191.96266d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.999825d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium192() }, { 0.00035099999999999997d, new GammaParticle(56710.0, 0.02186) }, { 0.231872415225d, new GammaParticle(10728.0, 0.11557) } } },
            { 0.00017500000000000003d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum192() }, { 1.0d, new BetaParticle(-1, 754800.0) }, { 0.1892d, new GammaParticle(295956.5, 0.00419) }, { 0.9224d, new GammaParticle(316506.18, 0.00392) }, { 0.036736d, new GammaParticle(612462.1, 0.00202) }, { 0.025795701309174d, new GammaParticle(11070.0, 0.112) }, { 0.01725666769611762d, new GammaParticle(65122.0, 0.01904) }, { 0.02949857725832072d, new GammaParticle(66832.0, 0.01855) }, { 0.009925491347248573d, new GammaParticle(75821.0, 0.01635) }, { 0.012764181872561666d, new GammaParticle(76725.0, 0.01616) }, { 0.002838690525313092d, new GammaParticle(77832.0, 0.01593) } } },

        };
    }
}
    