using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten190 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten190";
        public override double halfLife { get; } = 1800.0d;
        public override double atomicWeight { get; } = 189.9631d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium190() }, { 1.0d, new BetaParticle(-1, 606500.0) }, { 0.39d, new GammaParticle(157600.0, 0.00787) }, { 0.11d, new GammaParticle(162100.0, 0.00765) }, { 0.3382075113d, new GammaParticle(10063.0, 0.12321) }, { 0.3021652120718189d, new GammaParticle(59718.0, 0.02076) }, { 0.5227771835152576d, new GammaParticle(61141.0, 0.02028) }, { 0.17377408333040217d, new GammaParticle(69395.0, 0.01787) }, { 0.2219095044129236d, new GammaParticle(70206.0, 0.01766) }, { 0.048135421082521404d, new GammaParticle(71195.0, 0.01741) } } },

        };
    }
}
    