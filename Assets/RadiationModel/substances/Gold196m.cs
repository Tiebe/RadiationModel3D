using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold196m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold196m";
        public override double halfLife { get; } = 8.1d;
        public override double atomicWeight { get; } = 195.96666d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold196() }, { 0.0030499999999999998d, new GammaParticle(84660.0, 0.01464) }, { 0.2502765572776d, new GammaParticle(11419.0, 0.10858) }, { 0.0002457802905890165d, new GammaParticle(66991.0, 0.01851) }, { 0.00041842065132621125d, new GammaParticle(68806.0, 0.01802) }, { 0.00014118778749788393d, new GammaParticle(78048.0, 0.01589) }, { 0.0001819910580847724d, new GammaParticle(78983.0, 0.0157) }, { 4.080327058688846e-05d, new GammaParticle(80133.0, 0.01547) } } },

        };
    }
}
    