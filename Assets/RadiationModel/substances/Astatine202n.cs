using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine202n : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine202n";
        public override double halfLife { get; } = 0.46d;
        public override double atomicWeight { get; } = 201.98925d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9990000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine202() } } },
            { 0.00096d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth198() }, { 1.0d, new AlphaParticle(7961002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    