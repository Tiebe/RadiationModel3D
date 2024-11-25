using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium133m : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium133m";
        public override double halfLife { get; } = 1.1d;
        public override double atomicWeight { get; } = 132.91654d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Praseodymium133() }, { 0.16079999999999997d, new GammaParticle(61700.0, 0.02009) }, { 0.11630000000000001d, new GammaParticle(130400.0, 0.00951) }, { 0.188985101184d, new GammaParticle(5637.0, 0.21995) }, { 0.25757281607665894d, new GammaParticle(35551.0, 0.03488) }, { 0.47036672037373806d, new GammaParticle(36027.0, 0.03441) }, { 0.14309575760318713d, new GammaParticle(40857.0, 0.03035) }, { 0.17972827154960302d, new GammaParticle(41266.0, 0.03005) }, { 0.0366325139464159d, new GammaParticle(41766.0, 0.02969) } } },

        };
    }
}
    