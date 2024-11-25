using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium130m : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium130m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 129.93667d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium130() }, { 0.63d, new GammaParticle(128000.0, 0.00969) }, { 0.66d, new GammaParticle(138000.0, 0.00898) }, { 0.96d, new GammaParticle(539000.0, 0.0023) }, { 1.08d, new GammaParticle(1325000.0, 0.00094) }, { 0.041176325016d, new GammaParticle(3388.0, 0.36595) }, { 0.13427359939064523d, new GammaParticle(22983.0, 0.05395) }, { 0.2525363915566019d, new GammaParticle(23173.0, 0.0535) }, { 0.07039156434243049d, new GammaParticle(26184.0, 0.04735) }, { 0.08320282905275285d, new GammaParticle(26381.0, 0.047) }, { 0.012811264710322352d, new GammaParticle(26641.0, 0.04654) } } },

        };
    }
}
    