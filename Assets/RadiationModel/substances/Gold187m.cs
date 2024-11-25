using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold187m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold187m";
        public override double halfLife { get; } = 2.3d;
        public override double atomicWeight { get; } = 186.96467d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold187() }, { 0.0083d, new GammaParticle(101100.0, 0.01226) }, { 0.2506878562608d, new GammaParticle(11419.0, 0.10858) }, { 0.002145394672211642d, new GammaParticle(66991.0, 0.01851) }, { 0.0036523572901117495d, new GammaParticle(68806.0, 0.01802) }, { 0.0012324158554512096d, new GammaParticle(78048.0, 0.01589) }, { 0.001588584037676609d, new GammaParticle(78983.0, 0.0157) }, { 0.0003561681822253996d, new GammaParticle(80133.0, 0.01547) } } },

        };
    }
}
    