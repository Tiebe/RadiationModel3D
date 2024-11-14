using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium252 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium252";
        public override double halfLife { get; } = 0.369d;
        public override double atomicWeight { get; } = 252.09505d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.98d, new List<RadioactiveSubstance> { new AlphaParticle(10185047.4), new Mendelevium248() } },
            { 0.02d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    