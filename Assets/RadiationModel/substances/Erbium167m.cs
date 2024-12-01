using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Erbium167m : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium167m";
        public override double halfLife { get; } = 2.269d;
        public override double atomicWeight { get; } = 166.93228d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Erbium167()), new(0.424d, new GammaParticle(207801.0, 0.00597)), new(0.09862560000000001d, new GammaParticle(7933.0, 0.15629)), new(0.05380252935637229d, new GammaParticle(48222.0, 0.02571)), new(0.09549614724240733d, new GammaParticle(49128.0, 0.02524)), new(0.031032796350174904d, new GammaParticle(55779.0, 0.02223)), new(0.039101323401220384d, new GammaParticle(56399.0, 0.02198)), new(0.008068527051045474d, new GammaParticle(57145.0, 0.0217)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    