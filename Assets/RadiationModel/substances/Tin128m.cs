using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tin128m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin128m";
        public override double halfLife { get; } = 6.5d;
        public override double atomicWeight { get; } = 127.91275d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin128()), new(0.036000000000000004d, new GammaParticle(91150.0, 0.0136)), new(1.0d, new GammaParticle(831540.0, 0.00149)), new(1.0d, new GammaParticle(1168800.0, 0.00106)), new(0.056266225600000004d, new GammaParticle(3753.0, 0.33036)), new(0.07154635192176487d, new GammaParticle(25044.0, 0.04951)), new(0.1339067039523954d, new GammaParticle(25271.0, 0.04906)), new(0.037863779553750844d, new GammaParticle(28579.0, 0.04338)), new(0.04532294412583976d, new GammaParticle(28810.0, 0.04304)), new(0.007459164572088917d, new GammaParticle(29107.0, 0.0426)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    