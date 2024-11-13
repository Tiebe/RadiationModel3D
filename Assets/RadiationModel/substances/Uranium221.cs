
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium221 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium221";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 221.02632d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Thorium217() } },

        };
    }
}
    
    