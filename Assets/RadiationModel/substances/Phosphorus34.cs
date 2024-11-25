using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus34 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus34";
        public override double halfLife { get; } = 12.43d;
        public override double atomicWeight { get; } = 33.97365d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sulfur34() }, { 1.0d, new BetaParticle(-1, 2691495.0) }, { 0.00045d, new GammaParticle(1788794.0, 0.00069) }, { 0.00042d, new GammaParticle(1947060.0, 0.00064) }, { 0.001305d, new GammaParticle(1987190.0, 0.00062) }, { 0.15d, new GammaParticle(2127499.0, 0.00058) }, { 0.0006900000000000001d, new GammaParticle(4074418.0, 0.0003) }, { 0.0018d, new GammaParticle(4114520.0, 0.0003) }, { 2.4305520365549996e-09d, new GammaParticle(185.0, 6.70185) }, { 3.525104197901877e-08d, new GammaParticle(2306.0, 0.53766) }, { 6.976260039386258e-08d, new GammaParticle(2308.0, 0.53719) }, { 6.510845827118645e-09d, new GammaParticle(2466.0, 0.50277) }, { 6.510845827118645e-09d, new GammaParticle(2466.0, 0.50277) } } },

        };
    }
}
    