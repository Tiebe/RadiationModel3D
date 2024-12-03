using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Vanadium46m : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium46m";
        public override double halfLife { get; } = 0.00102d;
        public override double atomicWeight { get; } = 45.96106d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Vanadium46()), new(1.0d, new GammaParticle(801100.0, 0.00155)), new(5.26044414e-06d, new GammaParticle(536.0, 2.31314)), new(6.439609000305949e-05d, new GammaParticle(4945.0, 0.25073)), new(0.00012668914027751227d, new GammaParticle(4952.0, 0.25037)), new(2.549076971942827e-05d, new GammaParticle(5444.0, 0.22774)), new(2.549076971942827e-05d, new GammaParticle(5444.0, 0.22774)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    