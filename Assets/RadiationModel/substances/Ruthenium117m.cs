using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ruthenium117m : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium117m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 116.93633d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ruthenium117()), new(0.02613d, new GammaParticle(57800.0, 0.02145)), new(0.18760000000000002d, new GammaParticle(82500.0, 0.01503)), new(0.1809d, new GammaParticle(102900.0, 0.01205)), new(0.03417d, new GammaParticle(127400.0, 0.00973)), new(0.67d, new GammaParticle(184600.0, 0.00672)), new(0.0027917214012000004d, new GammaParticle(2737.0, 0.45299)), new(0.01254526765900521d, new GammaParticle(19150.0, 0.06474)), new(0.02380506197154689d, new GammaParticle(19279.0, 0.06431)), new(0.006397282624309728d, new GammaParticle(21736.0, 0.05704)), new(0.007433642409447903d, new GammaParticle(21875.0, 0.05668)), new(0.001036359785138176d, new GammaParticle(22072.0, 0.05617)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    