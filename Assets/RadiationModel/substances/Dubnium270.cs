
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium270 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium270";
        public override double halfLife { get; } = 6120.0d;
        public override double atomicWeight { get; } = 270.1314d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.87d, new List<RadioactiveSubstance> {  } },

            { 0.13d, new List<RadioactiveSubstance> { new AlphaParticle(), new Lawrencium266() } },

        };
    }
}
    
    