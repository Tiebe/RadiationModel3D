
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium224 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium224";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 224.03439d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Protactinium220() } },

        };
    }
}
    
    