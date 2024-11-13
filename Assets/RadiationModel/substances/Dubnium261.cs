
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium261 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium261";
        public override double halfLife { get; } = 4.7d;
        public override double atomicWeight { get; } = 261.11198d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.73d, new List<RadioactiveSubstance> {  } },

            { 0.27d, new List<RadioactiveSubstance> { new AlphaParticle(), new Lawrencium257() } },

        };
    }
}
    
    