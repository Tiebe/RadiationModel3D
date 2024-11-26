using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium177p : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium177p";
        public override double halfLife { get; } = 3084.0d;
        public override double atomicWeight { get; } = 176.94617d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium177() }, { 0.009899999999999999d, new GammaParticle(120500.0, 0.01029) }, { 0.41100000000000003d, new GammaParticle(214000.0, 0.00579) }, { 0.0137d, new GammaParticle(254800.0, 0.00487) }, { 0.7609999999999999d, new GammaParticle(277300.0, 0.00447) }, { 0.7d, new GammaParticle(295100.0, 0.0042) }, { 0.59d, new GammaParticle(311500.0, 0.00398) }, { 0.69d, new GammaParticle(326700.0, 0.0038) }, { 0.07200000000000001d, new GammaParticle(572400.0, 0.00217) }, { 0.11599999999999999d, new GammaParticle(606500.0, 0.00204) }, { 0.203d, new GammaParticle(638200.0, 0.00194) }, { 0.23196201544880002d, new GammaParticle(9114.0, 0.13604) }, { 0.16123702737187898d, new GammaParticle(54608.0, 0.0227) }, { 0.2821789068461305d, new GammaParticle(55786.0, 0.02222) }, { 0.0930928480678694d, new GammaParticle(63333.0, 0.01958) }, { 0.11794863850199051d, new GammaParticle(64057.0, 0.01936) }, { 0.02485579043412113d, new GammaParticle(64935.0, 0.01909) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    