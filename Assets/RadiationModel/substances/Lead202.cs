using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead202 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead202";
        public override double halfLife { get; } = 1656738613666.08d;
        public override double atomicWeight { get; } = 201.97215d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium202()), new(0.20552d, new GammaParticle(12148.0, 0.10206)) } },
            { 0.01d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury198()), new(1.0d, new AlphaParticle(3610302.0900000003)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    