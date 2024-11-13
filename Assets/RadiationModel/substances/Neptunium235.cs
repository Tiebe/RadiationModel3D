
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium235 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium235";
        public override double halfLife { get; } = 34223040.0d;
        public override double atomicWeight { get; } = 235.04406d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.999974d, new List<RadioactiveSubstance> { new Uranium235() } },

            { 2.6e-05d, new List<RadioactiveSubstance> { new AlphaParticle(), new Protactinium231() } },

        };
    }
}
    
    