using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium252 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium252";
        public override double halfLife { get; } = 2.46d;
        public override double atomicWeight { get; } = 252.08897d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.653d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Fermium248()), new(1.0d, new AlphaParticle(9570002.09)) } },
            { 0.33d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.017d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Fermium252()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    