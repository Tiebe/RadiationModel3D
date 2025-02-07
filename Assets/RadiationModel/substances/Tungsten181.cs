using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tungsten181 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten181";
        public override double halfLife { get; } = 10471680.0d;
        public override double atomicWeight { get; } = 180.94822d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tantalum181()), new(0.0103d, new GammaParticle(6240.0, 0.19869)), new(0.00031099999999999997d, new GammaParticle(136280.0, 0.0091)), new(0.00083d, new GammaParticle(152320.0, 0.00814)), new(0.218668051284992d, new GammaParticle(9424.0, 0.13156)), new(0.18729560095502865d, new GammaParticle(56280.0, 0.02203)), new(0.3265265009676232d, new GammaParticle(57535.0, 0.02155)), new(0.10802401670342367d, new GammaParticle(65315.0, 0.01898)), new(0.13719050121334805d, new GammaParticle(66067.0, 0.01877)), new(0.029166484509924387d, new GammaParticle(66981.0, 0.01851)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    