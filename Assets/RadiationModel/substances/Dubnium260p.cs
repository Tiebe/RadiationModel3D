using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium260p : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium260p";
        public override double halfLife { get; } = 1.52d;
        public override double atomicWeight { get; } = 260.1114d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.904d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lawrencium256()), new(1.0d, new AlphaParticle(10617002.09)) } },
            { 0.096d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.025d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rutherfordium260()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    